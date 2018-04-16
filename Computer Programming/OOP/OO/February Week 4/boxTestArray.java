/**
 * @(#)boxTestArray.java
 * Create an array of different boxes
 * but they will be stored in a box object array
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class boxTestArray {

    public static void main(String args[]) {

    	//create the box object array
    	box b[] = new box[4];

    	b[0] = new box();
    	b[1] = new Woodenbox();
    	b[2] = new Steelbox();
    	b[3] = new Largesteelbox();

    	for(int i = 0;i<b.length;i++){
    		b[i].info();
    	}//end for

    }//end method


}//end class