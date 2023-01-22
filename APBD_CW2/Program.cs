using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

/**
 * 
 * Jakub Szymczuk s20289
 * */

namespace APBD_CW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var csvPath = args.Length > 0 ? args[0] : @"Files\data.csv";
                var resulPath = args.Length > 1 ? args[1] : @"Files\result";
                var type = args.Length > 2 ? args[2] : "xml";
                if (!File.Exists(csvPath))
                {
                    throw new FileNotFoundException("Nie znaleziono pliku:", csvPath.Split("\\")[^1]);
                }


                University university = new University()
                {
                    Author = "Jakub Szymczuk"
                };

                foreach (var line in File.ReadLines(csvPath))
                {

                    string[] student = line.Split(',');

                    if (student.Length != 9)
                    {
                        File.AppendAllText(@"Files\Log.txt", $"{DateTime.UtcNow} Podana ścieżka jest niepoprawna\n");

                    }


                    Studies studies = new()
                    {
                        Name = student[2],
                        Mode = student[3]
                    };

                    Student student_ = new()
                    {
                        Name = student[0],
                        LastName = student[1],
                        Studies = studies,
                        Id = student[4],
                        BirthDate = student[5],
                        Email = student[6],
                        MothersName = student[7],
                        FathersName = student[8]
                    };

                    university.studentsAll.Add(student_);

                    ActiveStudies active = new()
                    {
                        Name = student[2],
                        NumberOfStudents = 1
                    };

                    if (university.getActive(active) != null)
                    {
                        university.getActive(active).NumberOfStudents++;
                    }
                    else
                    {
                        university.activeStudies.Add(active);
                    }




                }


                using var writer = new FileStream($"{resulPath}.{type}", FileMode.Open);
                var serializer = new XmlSerializer(typeof(University));
                serializer.Serialize(writer, university);

                var jsonString = JsonSerializer.Serialize(university);
                File.WriteAllText($"{resulPath}.json", jsonString);

            }
            catch (FileNotFoundException e) {
                File.AppendAllText(@"Files\Log.txt", $"{DateTime.UtcNow} {e.Message} Plik nie istnieje({e.FileName})\n");
            }

        }
    }
}
