using System.Data;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

public class Journal
    {
        // creates a new entry list to store journal entries
        public List<Entry> _entries = new List<Entry>();

        // function that adds a new entry to the entry list
        public void AddEntry(Entry newEntry)
            {
                _entries.Add(newEntry);
            }

        // Function to display all journal entries by looping through each entry in the entry list
        public void DisplayAll()
            {
                foreach (Entry entry in _entries)
                    {
                        entry.Display();
                    }

            }

        // function that will save all journal entries in the entries list by writting date, promptstring, and entry to a file entered by the user
        // Added save to mysql database commands.  Will truncate the entries table before insert to avoid duplicate rows.
        public void SaveToFile(string database)
            { 
                //using (StreamWriter outputFile = new StreamWriter(file))
                //    {
                //        foreach (Entry entry in _entries)
                //            {
                //                outputFile.WriteLine($"{entry._date}|{entry._promptString}|{entry._entryText}");
                //            }
                //    }
                string MyConnectionString = $"Server=localhost;Database={database};Uid=root;Pwd=admin";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd;

                connection.Open();

                cmd = connection.CreateCommand();
                cmd.CommandText = "truncate table entries";
                cmd.ExecuteNonQuery();

                foreach (Entry entry in _entries)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into entries(DATE,PROMPTS,ENTRY) values (@date,@prompt,@entry)";
                    cmd.Parameters.AddWithValue("@date", entry._date);
                    cmd.Parameters.AddWithValue("@prompt", entry._promptString);
                    cmd.Parameters.AddWithValue("@entry", entry._entryText);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }

        // Function will load date, prompt, and entry from a user specified file and will create a new entry for each line in the file
        // Added mysql database which will ask the user for the database to use and will select from the entries table.
        public void LoadFromFile(string database)
            {
                //string[] lines = File.ReadAllLines(file);

                //foreach (string line in lines)
                //{
                //    string[] parts = line.Split("|");

                //    string lineDate = parts[0];
                //    string linePromptString = parts[1];
                //    string lineEntryText = parts[2];

                //    Entry newEntry = new Entry();
                //    newEntry._date = lineDate;
                //    newEntry._promptString = linePromptString;
                //    newEntry._entryText = lineEntryText;
                //    AddEntry(newEntry);
                //}
                string MyConnectionString = $"Server=localhost;Database={database};Uid=root;Pwd=admin";
                
                using (MySqlConnection connection = new MySqlConnection(MyConnectionString))
                {
                    connection.Open();
                    string cmd = "select date,prompts,entry from entries";
                    MySqlCommand GetEntries = new MySqlCommand(cmd, connection);

                    using (MySqlDataReader reader = GetEntries.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dbDate = Convert.ToString(reader.GetValue(0));
                            string dbPrompt = Convert.ToString(reader.GetValue(1));
                            string dbentry = Convert.ToString(reader.GetValue(2));

                            Entry newEntry = new Entry();
                            newEntry._date = dbDate;
                            newEntry._promptString = dbPrompt;
                            newEntry._entryText = dbentry;
                            AddEntry(newEntry);
                        }
                    }
                    connection.Close();
                }
            }

    }