/**
 * @(#)PersonTest.java
 *
 *
 * @author
 * @version 1.00 2016/1/8
 */


public class PersonTest {

    public static void main( String args[]) {

    	//create a phone object first
    	Phone P1 = new Phone("HTC 626", "Blue", 1252);
    	//creat a person
    	Person prsn = new Person(111, "Grit Jones", P1);

    	System.out.println(prsn.toString());

    }


}