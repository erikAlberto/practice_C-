Feature: Manage tasks
	Add, edit and delete a task in the Todo app

Scenario: Add a new task
    Given I am on task list page
    When I add a new task called "learn c#"
	And I add a note "yes" for the new task
    And I save the task
    Then I should see the "learn c#" task in the list page

Scenario: Edit a task
	Given I am on task list page
	And I select the task "learn c#" on task list page
	When I edit task name to be "modificado"
	And I edit task note to be "now"
	And I save the task
	Then I should see the "modificado" task name in the task list page

Scenario: Delete a task
	Given I am on task list page
	And I select the task "learn c#" on task list page
	When I delete the task selected
	Then I should not see the "learn c#" task on task list page
