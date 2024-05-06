using System;
using System.Threading.Tasks;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;

    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }

    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string titleTask = "Zad.1";
        DateTime dat1 = DateTime.Today;

        this._toDoList.AddTask(titleTask, dat1);

        // Act

        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] Zad.1 - Due:"));


    }
    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string titleTask = "to complete";
        DateTime dat1 = DateTime.Today;

        this._toDoList.AddTask(titleTask, dat1);
        this._toDoList.CompleteTask(titleTask);

        // Act

        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[✓] to complete - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string titleTask = "to complete";

        //this._toDoList.CompleteTask(titleTask);

        // Act && Assert 
        Assert.That(() => this._toDoList.CompleteTask(titleTask), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));

    }
    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string titleTask = "Zad.1";
        DateTime dat1 = DateTime.Today;
        this._toDoList.AddTask(titleTask, dat1);
        string titleTask2 = "to complete";
        DateTime dat12 = DateTime.Today;

        this._toDoList.AddTask(titleTask2, dat12);
        this._toDoList.CompleteTask(titleTask2);

        // Act

        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] Zad.1 - Due:"));
        Assert.That(result, Does.Contain("[✓] to complete - Due:"));
    }
} 
