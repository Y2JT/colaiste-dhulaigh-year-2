/**
 * @(#)Student1.java
 *
 *Creat a student object that has a name, id and college. (college is an object)
 *Creat a college object with name address and number of courses
 *int the test class creat a student object and print the detail of the (Create the college object first
 */


public class Student1 {


	//Attributes
	private String name;
	private int id;
	private College C1;

    public Student1(String n, int id, College C) {
    	name = ((n.length()>0)?n : "Unknown");
    	this.id = ((id>0)?id : 1);
    	C1 = C;
    }//end method

    public String toString(){
    	return "\nName : " + name + "\nID : " + id + "\nCollege : \n" + C1;
    }

}