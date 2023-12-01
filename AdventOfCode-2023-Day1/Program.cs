
using System.Runtime.InteropServices;





void PartOne() {
    StreamReader streamReader = new StreamReader("Input.txt");
    int Calibration = 0;
    string line = streamReader.ReadLine();


    while (line != null) {
        int FirstNumber = -1;
        int SecondNumber = -1;
        for (int i = 0; i < line.Length; i++) {
            if (char.IsNumber(line[i])) {
                if (FirstNumber == -1) {
                    FirstNumber = line[i] - '0';
                } else {
                    SecondNumber = line[i] - '0';
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
}

void PartTwo() {
    StreamReader streamReader = new StreamReader("Input.txt");

    List<string> Numbers = new List<string>() {  "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",  "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    int Calibration = 0;
    string line = streamReader.ReadLine();


    while (line != null) {
        string FirstNumber = "";
        string SecondNumber = "";
        Dictionary<int, string> NumbersInLine = new Dictionary<int, string>();

        for (int i = 0; i < Numbers.Count; i++) {
            if (line.Contains(Numbers[i])) {
                NumbersInLine.Add(NumbersInLine.Count, Numbers[i]);
            }
        }
        int FirstIndex = -1;
        int LastIndex = -1;
        for (int i = 0; i < NumbersInLine.Count; i++) {
            int TempIndex = line.IndexOf(NumbersInLine[i]);
            if (FirstIndex == -1 || TempIndex < FirstIndex) {
                FirstNumber = NumbersInLine[i];
                FirstIndex = TempIndex;
            } else if (LastIndex == -1 || TempIndex > LastIndex) {
                SecondNumber = NumbersInLine[i];
                LastIndex = TempIndex;
            }
        }
        int NumberToAdd = 0;
        if (FirstNumber.Length == 1) {
            switch (FirstNumber) {
                case "1": {
                    NumberToAdd = 1;
                    break;
                }
                case "2": {
                    NumberToAdd = 2;
                    break;
                }
                case "3": {
                    NumberToAdd = 3;
                    break;
                }
                case "4": {
                    NumberToAdd = 4;
                    break;
                }
                case "5": {
                    NumberToAdd = 5;
                    break;
                }
                case "6": {
                    NumberToAdd = 6;
                    break;
                }
                case "7": {
                    NumberToAdd = 7;
                    break;
                }
                case "8": {
                    NumberToAdd = 8;
                    break;
                }
                case "9": {
                    NumberToAdd = 9;
                    break;
                }

            }
        } else {
            switch (FirstNumber) {
                case "one": {
                    NumberToAdd = 1;
                    break;
                }
                case "two": {
                    NumberToAdd = 2;
                    break;
                }
                case "three": {
                    NumberToAdd = 3;
                    break;
                }
                case "four": {
                    NumberToAdd = 4;
                    break;
                }
                case "five": {
                    NumberToAdd = 5;
                    break;
                }
                case "six": {
                    NumberToAdd = 6;
                    break;
                }
                case "seven": {
                    NumberToAdd = 7;
                    break;
                }
                case "eight": {
                    NumberToAdd = 8;
                    break;
                }
                case "nine": {
                    NumberToAdd = 9;
                    break;
                }

            }
        }

        int SecondNumberToAdd = 0;
        if (SecondNumber.Length == 1) {
            switch (SecondNumber) {
                case "1": {
                    SecondNumberToAdd = 1;
                    break;
                }
                case "2": {
                    SecondNumberToAdd = 2;
                    break;
                }
                case "3": {
                    SecondNumberToAdd = 3;
                    break;
                }
                case "4": {
                    SecondNumberToAdd = 4;
                    break;
                }
                case "5": {
                    SecondNumberToAdd = 5;
                    break;
                }
                case "6": {
                    SecondNumberToAdd = 6;
                    break;
                }
                case "7": {
                    SecondNumberToAdd = 7;
                    break;
                }
                case "8": {
                    SecondNumberToAdd = 8;
                    break;
                }
                case "9": {
                    SecondNumberToAdd = 9;
                    break;
                }

            }
        } else {
            switch (SecondNumber) {
                case "one": {
                    SecondNumberToAdd = 1;
                    break;
                }
                case "two": {
                    SecondNumberToAdd = 2;
                    break;
                }
                case "three": {
                    SecondNumberToAdd = 3;
                    break;
                }
                case "four": {
                    SecondNumberToAdd = 4;
                    break;
                }
                case "five": {
                    SecondNumberToAdd = 5;
                    break;
                }
                case "six": {
                    SecondNumberToAdd = 6;
                    break;
                }
                case "seven": {
                    SecondNumberToAdd = 7;
                    break;
                }
                case "eight": {
                    SecondNumberToAdd = 8;
                    break;
                }
                case "nine": {
                    SecondNumberToAdd = 9;
                    break;
                }

            }
        }


        string Num = "";
        if (SecondNumber != "") {
            Num = Convert.ToString(NumberToAdd) + Convert.ToString(SecondNumberToAdd);
        } else {
            Num = Convert.ToString(NumberToAdd) + Convert.ToString(SecondNumberToAdd);
        }
        
        Calibration += Convert.ToInt32(Num);


        line = streamReader.ReadLine();

    }
    Console.WriteLine(Calibration);
}


PartOne();
PartTwo();