using System;

using (FileStream fs = new FileStream(path, FileMode.Create))
{
    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    {
        string line;
        while ((line = sr.ReadLine())) != null){
            Debug.Log(line);
        }
    }
}