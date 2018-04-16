/**
 * @(#)student.java
 *
 *
 * @author
 * @version 1.00 2016/3/3
 */


public class student {

	private String name;
	private int id;
	private phone p1;
	private static int count = 0;

    public student(String n, int i, phone p) {
    	name = ((n.length()>0)? n : "Unknown");
    	id = ((i>0)? i : 111);
    	p1 = p;
    	count++;
    }//end constructor

    //toString
    public String toString(){
    	return "\nName: " + name + "\nID: " + id + p1;
    }//end toString

    private static int getcount(){
    	return count;
    }//end getcount

}//end class