Feature: TodoTest
	In Todo app you want to be able to add, edit and delete tasks

Background: 
	Given I launch Todo APP

Scenario: Add new Task
	Given I tap add tasks (+) button
	When I enter a new task called "task1"
		And I enter a note for the new task "yes"
	    And I save the task
    Then Verify if the following task is displayed in the list: task1

Scenario: Edit a task
	Given I tap add tasks (+) button
		And I enter a new task called "task1"
		And I enter a note for the new task "yes"
		And I save the task
	When I select the task "task1" on task list page
		And I edit task name to be "modificado"
		And I edit task note to be "now"
		And I set task as Done
		And I save the task
	Then Verify if the following task is displayed in the list: modificado

Scenario: Delete a task
	Given I tap add tasks (+) button
		And I enter a new task called "task2"
		And I enter a note for the new task "yes"
		And I save the task
	When I select the task "task1" on task list page
		And I delete the task selected
	Then I should not see the "task1" task on task list page
