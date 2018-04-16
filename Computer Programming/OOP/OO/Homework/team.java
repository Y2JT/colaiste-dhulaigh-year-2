/**
 * @(#)team.java
 * Create a team object with attributes name, league_position and num_goals
 * Have a constructor, set and get methods and a toString method
 * Take the details from the user
 * Create a team object and then change the details using set methods
 * Print the new details using get methods
 *
 * @author
 * @version 1.00 2015/12/10
 */


public class team {
	private String name;
    private int league_position, num_goals;

	//constructor
    public team(String name, int league_position, int num_goals) {
    	this.name = ((name.length()>0)?name : "Unknown");
    	this.league_position = ((league_position>0)?league_position : 1);
    	this.num_goals = ((num_goals>0)?num_goals : 1);
    }//end constructor

    //setname method
    public void setname(String name){
    	this.name = ((name.length()>0)?name : "Unknown");
    }//end setname method

    //getname method
    public String getname(){
    	return name;
    }//end getname method

    //setleague method
    public void setleague(int league_position){
    	this.league_position = ((league_position>0)?league_position : 1);
    }//end setleague method

    //getleague method
    public int getleague(){
    	return league_position;
    }//end getleague method

    //setgoals method
    public void setgoals(int num_goals){
    	this.num_goals = ((num_goals>0)?num_goals : 1);
    }//end setgoals method

    //getgoals method
    public int getgoals(){
    	return num_goals;
    }//end get goals method

    //toString method
    public String toString(){
    	return "\nTeam Details:\n\nTeam Name: " + name + "\nLeague Position: " + league_position + "\nNumber of Goals: " + num_goals;
    }//end toString method


}//end class