Feature: MortgageInsuranceValidation
#The Payment Schedule is re-calculated and show in the same page.
#The Drop off years for PMI changes


@MortgageInsurance
@GiveInput
Scenario Outline: Enter PMI rate data in Mortgage Insurance Page
Given user launches TRID application with <url>
	And user navigates to Mortgage Insurance Page
	And user have the input values from excel sheet <sheetName>
When user enters pmi rate values
Then Pmi Rates Grid should have inserted values
Examples: 
	| url                                                                                                    | sheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | MortgageInsurance |


@MortgageInsurance
Scenario Outline: Set value lesser than default value for lower of cost or appraisal in Mortgage Insurance Page
Given user launches TRID application with <url>
	And user navigates to Mortgage Insurance Page
	And user have the input values from excel sheet <sheetName>
When user enters pmi rate values
	And user enters <inputValue> lesser than default value for lower of cost or appraisal
	And click on Other PMI inputs TEST Button
Then Payment Schedule is recalculated with new lower of cost value <inputValue>
	And Drop off years for PMI changes to <computedDate>
Examples: 
	| url                                                                                                    | defaultValue | inputValue | computedDate | sheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | 155000       | 131189     | 3/1/2016     | MortgageInsurance |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | 155000       | 131188     | 3/1/2016     | MortgageInsurance |



@MortgageInsurance
Scenario Outline: Set value greater than default value for lower of cost or appraisal in Mortgage Insurance Page
Given user launches TRID application with <url>
	And user navigates to Mortgage Insurance Page
	And user have the input values from excel sheet <sheetName>
When user enters pmi rate values
	And user enters <inputValue> greater than default value for lower of cost or appraisal
	And click on Other PMI inputs TEST Button
Then Payment Schedule is recalculated with new lower of cost value <inputValue>
	And Drop off years for PMI changes to <computedDate>
Examples: 
	| url                                                                                                    | defaultValue | inputValue | computedDate | sheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | 155000       | 164860     | 3/1/2016     | MortgageInsurance |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | 155000       | 164861     | 3/1/2016     | MortgageInsurance |




