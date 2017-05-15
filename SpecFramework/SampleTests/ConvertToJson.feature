Feature: ConvertToJason

@mytag
Scenario Outline: Convert Excel values into JSON files
Given user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
Then convert Excel values into json format
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName |
	| 1R         | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
