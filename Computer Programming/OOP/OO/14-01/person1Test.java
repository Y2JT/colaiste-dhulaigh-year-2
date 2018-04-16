/**
 * @(#)person1Test.java
 * person1Test to go with person1
 *
 * @author
 * @version 1.00 2016/1/14
 */


public class person1Test {

    public static void main(String args[]) {

    	//create a phone
    	phone1 p1 = new phone1(556412,6,"Black");
    	//create a person
    	person1 p2 = new person1("Joey",21,"Games",p1);

    	System.out.print(p2.toString());
    	System.out.println();
    	System.out.println();

    }//end main method

}//end class