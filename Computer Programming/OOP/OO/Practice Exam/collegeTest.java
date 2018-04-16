/**
 * @(#)collegeTest.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */


public class collegeTest {

    public static void main(String args[]) {
    	
    	//create student
    	student s1 = new student("Joey",22,491);
    	//create college
    	college c1 = new college("CDCFE","Coolock",s1);
    	
    	System.out.print(c1.toString());
    	System.out.print(s1.talk());
    	
    }//end main
    
    
}//end class