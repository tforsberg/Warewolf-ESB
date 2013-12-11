﻿Feature: FindIndex
	In order to find where characters or values are in sentences or words
	As a Warewolf user
	I want a tool that finds indexes

Scenario: Find the first occurence of a character in a sentence
	Given I have a findindex variable "[[a]]" equal to "I have managed to spend time in real innovation since I started using Warewolf"
	And the sentence "[[a]]"
	And I selected Index "First Occurrence"
	And I search for characters "since"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "49"
	And the find index execution has "NO" error

Scenario: Find all occurences of a word in a sentence and output to scalar going left to right
	Given I have a findindex variable "[[a]]" equal to "I have managed to spend time in real innovation since I started using Warewolf"
	And the sentence "[[a]]"
	And I selected Index "All Occurrences"
	And I search for characters "a"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "4,9,11,35,43,59,72"
	And the find index execution has "NO" error

Scenario: Find all occurences of a word in a sentence and output to recordset going right to left 
	Given I have a findindex variable "[[a]]" equal to "I have managed to spend time in real innovation since I started using Warewolf"
	And the sentence "[[a]]"
	And I selected Index "All Occurrences"
	And I search for characters "a"
	And I selected direction as "Right to Left"
	When the data find index tool is executed
	Then the find index result is 
	| result |
	| 7      |
	| 20     |
	| 36     |
	| 44     |
	| 68     |
	| 70     |
	| 75     |
	And the find index execution has "NO" error

Scenario: Find last occurence of a bracket in a sentence
	Given I have a findindex variable "[[a]]" equal to "!@#$%)@#$%)"
	And the sentence "[[a]]"
	And I selected Index "Last Occurence"
	And I search for characters "a"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "11"
	And the find index execution has "NO" error

Scenario: Find first occurence of a character in a blank string
	Given I have a findindex variable "[[a]]" equal to ""
	And the sentence "[[a]]"
	And I selected Index "First Occurence"
	And I search for characters "a"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "-1"
	And the find index execution has "NO" error

Scenario: Find first occurence of a character in a string where it doesnt exist
	Given I have a findindex variable "[[a]]" equal to "fff"
	And the sentence "[[a]]"
	And I selected Index "First Occurence"
	And I search for characters "a"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "-1"
	And the find index execution has "NO" error

Scenario: Find all occurences of a character in a string where it doesnt exist
	Given I have a findindex variable "[[a]]" equal to ""
	And the sentence "[[a]]"
	And I selected Index "All Occurence"
	And I search for characters "a"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "-1"
	And the find index execution has "NO" error

Scenario: Find an xml fragment in a bigger xml document
	Given I have a findindex variable "[[a]]" equal to "<x><b id="1">One</b></x>"
	And the sentence "[[a]]"
	And I selected Index "First Occurence"
	And I have a findindex variable "[[id]]" equal to "1"
	And I search for characters "<b id=""[[id]]"">"
	And I selected direction as "Left to Right"
	When the data find index tool is executed
	Then the find index result is "4"
	And the find index execution has "NO" error
