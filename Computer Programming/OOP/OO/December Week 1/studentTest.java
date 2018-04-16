/**
 * @(#)studentTest.java
 * studentTest class to go with student.java
 *
 * @author
 * @version 1.00 2015/12/3
 */


public class studentTest {

    public static void main(String args[]) {

    	//create new student object
    	student s1 = new student("Joey", "Computer Science", 21);	//new keyword means its a new object

		System.out.println("Student Details\n" + s1.toString());

    }//end main method


}//end class