/**
 * @(#)phoneTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/4
 */


public class phoneTest {

    public static void main(String args[]) {

	//create app object
	App a1 = new App("Walking Dead",8,100);
	//create phone object
	phone p1 = new phone("iPhone","Black",a1);

	//print details
	System.out.println(p1.toString());
	System.out.println();	//blank line

    }//end main

}//end class