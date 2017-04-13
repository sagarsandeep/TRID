Feature: ClosingDisclosure


#============================================================================================================================ 
#================================ Closing Disclosure with No Prepaid, No PMI, No Escrow =====================================
#============================================================================================================================ 

@LoanDetails
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |

@LoanDetails
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |

@LoanDetails
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |

@LoanDetails
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


@LoanDetails
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure |


#============================================================================================================================ 
#============================== Closing Disclosure with No Prepaid, with PMI, with Escrow ===================================
#============================================================================================================================  

@LoanDetails
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user enters values for Cushion Months for Insurance
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |

@LoanDetails
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |


@LoanDetails
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |

@LoanDetails
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	And user navigate to Closing Disclosure Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |
