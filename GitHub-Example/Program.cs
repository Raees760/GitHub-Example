using static System.Console;

public class Program{

    static void Main(){
        HogwartsStudent[] hogwartsStudents = {
            new HogwartsStudentSimon(), new HogwartsStudentRaees(), new HogwartsStudentKyrone()
        };

        foreach(HogwartsStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}