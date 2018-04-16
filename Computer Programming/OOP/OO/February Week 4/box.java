/**
 * @(#)box.java
 *
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class box {

	private int width, height;

    public box() {
    }

    //method overloading
    public box(int w, int h){
    	width = w;
    	height = h;
    }

    public void info(){
    	System.out.println("This is a simple box");
    	System.out.println("Width is " + width + ", Height is " + height);
    }


}//end class