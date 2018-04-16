/**
 * @(#)StudentTest.java
 *
 *
 * @author
 * @version 1.00 2016/1/8
 */


public class StudentTest {

    public static void main( String args[]) {

    	//Create a college
    	College C1 = new College( "Cdcfe", "678, Oscar Traynor Road, Coolock", 128);
    	//Create a Student
    	Student1 St1 = new Student1("Ryan McHallon", 64, C1);

    	System.out.println(St1.toString());

    }


}