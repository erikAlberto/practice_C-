Feature: TodoTest
	In Todo app you want to be able to add, edit, delete and complete tasks 

Background: 
	Given I launch Todo APP
	And I tap + button
	When I enter a new task called "learn c#"
	And I enter a note for the new task "yes"
    And I save the task

Scenario: Add new Task
	
    Then I should see the task in the list page

Scenario: Edit a task
	
	When I select the task "learn c#" on task list page
	And I edit task name to be "modificado"
	And I edit task note to be "now"
	And I save the task
	Then I should see the task in the list page

Scenario: Delete a task
	When I select the task "learn c#" on task list page
	When I delete the task selected
	Then I should not see the "learn c#" task on task list page

Scenario: Add and complete a task
	When I select the task "learn c#" on task list page
	And I set task as Done
	And I save the task
	Then I should see the task in the list page
	And I should see an image next to task name
