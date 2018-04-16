/**
 * @(#)memory.java
 * memory to go with computer
 *
 * @author
 * @version 1.00 2016/1/14
 */


public class memory {

	//attributes
	private String manufacturer;
	private int size;

	//constructor
    public memory(String m, int s) {
    	this.manufacturer = ((m.length()>0)? m : "Unknown");
    	this.size = ((s>0)? s : 1);
    }//end constructor

	//setsize method
	public void setsize(int s){
    	this.size = ((s>0)? s : 1);
	}//end setsize

	//getsize method
	public int getsize(){
		return size;
	}//end getsize

	//toString
    public String toString(){
    	return "\nManufacturer: " + manufacturer + "\nSize (GB): " + size;
    }//end toString

}//end class