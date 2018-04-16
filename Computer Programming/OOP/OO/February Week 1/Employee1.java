/**
 * @(#)Employee1.java
 * Create an employee object with name, id and grade(1-4)
 * Use a setDetails method to set the attributes and not the constructor
 * Have a bonus method that will calculate the employees bonus which is 5% of their salary
 * Take values in from the user
 * Create a valid and invalid instance of employee
 * @author
 * @version 1.00 2016/2/4
 */


public class Employee1 {

	//attributes
	private String name;
	private int id, salary, grade;

	//empty constructor
	public Employee1(){
	}//end constructor

	//name and id only
	public Employee1(String name, int id){
		setDetails(name, id,0,0);
	}//end constructor

	//constructor
    public Employee1(String name, int id, int salary, int grade) {
    	setDetails(name, id, salary, grade);
    }//end constructor

    public void setDetails(String name, int id, int salary, int grade){
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.id = ((id>0)? id: 111);
    	this.salary = ((salary>0)? salary : 111);
    	this.grade = ((grade>0 && grade<5)? grade : 111);
    }//end setDetails

    //bonus method
    public int bonus(int salary){
		return 5 * salary / 100;
    }//end bouns method

    public String getname(){
    	return name;
    }//end getname

    //toString
    public String toString(){
    	return "\nName: " + name + "\nID: " + id + "\nSalary: $" + salary + "\nGrade: " + grade;
    }//end toString

}//end class