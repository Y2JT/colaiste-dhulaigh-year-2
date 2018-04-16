/**
 * @(#)boxTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class boxTest {

    public static void main(String args[]) {

    	//create a box object
    	box b1 = new box();
    	box b2 = new box(5,12);
		box b3 = new Woodenbox();
		box b4 = new Steelbox();
		box b5 = new Largesteelbox();

    	b1.info();
    	b2.info();
    	b3.info();
    	b4.info();
    	b5.info();

    }//end method


}//end class