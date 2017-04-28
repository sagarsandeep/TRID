Feature: ClosingDisclosure


#============================================================================================================================ 
#================================ Closing Disclosure with Prepaid, No PMI, No Escrow ========================================
#============================================================================================================================ 

@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
	| 41R | 2            | PrepaidCharges | 22           | ClosingDisclosure |


#============================================================================================================================ 
#============================== Closing Disclosure with No Prepaid, with PMI, with Escrow ===================================
#============================================================================================================================  

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |
	


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user have variable loan data from excel sheet <vSheetName> for the scenario <vScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName | vScenarioNo | vSheetName          |
	| 1R    | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     | 1           | VariableLoanDetails |
	| 2R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     | 1           | VariableLoanDetails |
	| 3R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     | 1           | VariableLoanDetails |
	| 4R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     | 1           | VariableLoanDetails |
	| 6R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     | 1           | VariableLoanDetails |
	| 7R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     | 1           | VariableLoanDetails |
	| 8R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     | 1           | VariableLoanDetails |
	| 9R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     | 1           | VariableLoanDetails |
	| 11R   | 9            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     | 1           | VariableLoanDetails |
	| 12R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 10          | Escrow     | 1           | VariableLoanDetails |
	| 13R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 11          | Escrow     | 1           | VariableLoanDetails |
	| 14R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 12          | Escrow     | 1           | VariableLoanDetails |
	| 16R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 13          | Escrow     | 1           | VariableLoanDetails |
	| 17R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 14          | Escrow     | 1           | VariableLoanDetails |
	| 19R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 15          | Escrow     | 1           | VariableLoanDetails |
	| 36R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 16          | Escrow     | 1           | VariableLoanDetails |
	| 37R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 17          | Escrow     | 2           | VariableLoanDetails |
	| 38R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 18          | Escrow     | 3           | VariableLoanDetails |
	| 38.1R | 19           | MortgageInsurance | 19           | ClosingDisclosure | 19          | Escrow     | 4           | VariableLoanDetails |



#============================================================================================================================ 
#================================ Closing Disclosure with No Prepaid, With PMI, No Escrow ===================================
#============================================================================================================================ 

@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |

@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |

@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |

@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |


@NoPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 39R | 20           | MortgageInsurance | 20           | ClosingDisclosure |

#============================================================================================================================ 
#================================ Closing Disclosure with No Prepaid, No PMI, With Escrow ===================================
#============================================================================================================================ 

@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 
	


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 

@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 

@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 40R | 21           | ClosingDisclosure | 21          | Escrow     | 


#============================================================================================================================ 
#================================ Closing Disclosure with Prepaid, With PMI, No Escrow ======================================
#============================================================================================================================ 

@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |

@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |

@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |

@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


@WithPrepaid
@WithPMI
@NoEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with Prepaid, with PMI, No Escrow
Given user is at TRID application homepage
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
	| 42R | 3            | PrepaidCharges | 23           | MortgageInsurance | 23           | ClosingDisclosure |


#============================================================================================================================ 
#================================ Closing Disclosure with Prepaid, No PMI, With Escrow ======================================
#============================================================================================================================ 

@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |
	


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
	And Enter Loan detail input values for computation
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Escrow Property
	And user enters disclosed input values for Prepaid Charges
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
	Examples: 
	| No  | pcScenarioNo | pcSheetName    | eScenarioNo | eSheetName | cdScenarioNo | cdSheetName       |
	| 43R | 4            | PrepaidCharges | 24          | Escrow     | 24           | ClosingDisclosure |