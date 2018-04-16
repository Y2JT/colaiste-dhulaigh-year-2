/**
 * @(#)Person.java
 *
 *
 * @author
 * @version 1.00 2016/1/8
 */


public class Person {

	private int id;
    private String name;
    private Phone p1;

    public Person(int id, String n, Phone p){

    	this.id = ((id>0)?id : 1);
    	this.name = ((n.length>0)?n : "");
    	p1 = p;

    }

    public String toString(){

    	return "\nName: "+ name + "\nId: " + id + p1;

    } //end toString


}