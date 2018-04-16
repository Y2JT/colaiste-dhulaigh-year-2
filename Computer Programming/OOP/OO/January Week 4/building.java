/**
 * @(#)building.java
 * Create a building object with attributes location, size, number of floors. Have set and get methods
 * Create a school object. A school is a building but also has a name and capacity (number of people)
 * Create a school object in the test class and take inputs from the user
 *
 * @author
 * @version 1.00 2016/1/28
 */

public class building {

	private String location;
	private int size;
	private int num_floors;

	//constructor
    public building(String location, int size, int num_floors) {
    	this.location = location;
    	this.size = ((size>0)? size:1);
    	this.num_floors = ((num_floors>0)? num_floors:1);
    }//end constructor

    //setlocation method
    public void setlocation(String location){
    	this.location = location;
    }//end setlocation method

    //getlocation method
    public String getlocation(){
    	return location;
    }//end getlocation

    //setsize method
    public void setsize(int size){
    	this.size = ((size>0)? size:1);
    }//end setsize method

    //getsize method
    public int getsize(){
    	return size;
    }//end getsize method

    //setnumfloors method
    public void setnumfloors(int num_floors){
    	this.num_floors = ((num_floors>0)? num_floors:1);
    }//end setnumfloors

    //getnumfloors method
    public int getnumfloors(){
    	return num_floors;
    }//end getnumfloors method

    public String toString(){
    	return "\nLocation: " + location + "\nSize: " + size + "\nNumber of Floors: " + num_floors;
    }//end toString

}//end class