
using System.Runtime.InteropServices;

StreamReader streamReader = new StreamReader("Input.txt");

List<string> Numbers = new List<string>() { "Zero", "One", "Two", "Three" , "Four" , "Five", "Six", "Seven", "Eight", "Nine"};

int Calibration = 0;
string line = streamReader.ReadLine();


while (line != null) {
    int FirstNumber = -1;
    int SecondNumber = -1;
    List<char> NumberBuild = new List<char>();
    for (int i = 0; i < line.Length; i++) {
        NumberBuild.Add(line[i]);
        if (char.IsNumber(line[i])) {
            if (FirstNumber == -1) {
                FirstNumber = line[i] - '0';
            } else {
                SecondNumber = line[i] - '0';
            }
            NumberBuild.Clear();
        }else {
           for(int j  = 0; j < Numbers.Count;j++) {
                for (int k = 0; k<NumberBuild.Count;k++) {

                }
            }
        }
    }
    string CompleteNumber = "";
    if (SecondNumber == -1) {
        CompleteNumber = Convert.ToString(FirstNumber) + Convert.ToString(FirstNumber);
    } else {
        CompleteNumber = Convert.ToString(FirstNumber) + Convert.ToString(SecondNumber);
    }

    int Num = Convert.ToInt32(CompleteNumber);
    Calibration += Num;
    line = streamReader.ReadLine();

}

Console.WriteLine(Calibration);
