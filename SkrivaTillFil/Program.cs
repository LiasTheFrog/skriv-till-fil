FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read); 

StreamReader sr = new StreamReader(fs);

string sträng = sr.ReadToEnd();
sr.Close();
Console.WriteLine(sträng);