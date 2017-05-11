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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
| 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
| 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
| 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
| 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
| 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
| 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
| 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
| 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating In 5 Years card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |



@WithPrepaid
@NoPMI
@NoEscrow
Scenario Outline: Validating In 5 Years Principal card value on Closing Disclosure page with Prepaid, No PMI, No Escrow
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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
 | 41R | 42           | PrepaidCharges | 23           | ClosingDisclosure |
 | 50  | 46           | PrepaidCharges | 28           | ClosingDisclosure |
 | 51  | 47           | PrepaidCharges | 29           | ClosingDisclosure |
 | 52  | 48           | PrepaidCharges | 30           | ClosingDisclosure |
 | 53  | 49           | PrepaidCharges | 31           | ClosingDisclosure |
 | 54  | 50           | PrepaidCharges | 32           | ClosingDisclosure |
 | 55  | 51           | PrepaidCharges | 33           | ClosingDisclosure |
 | 56  | 52           | PrepaidCharges | 34           | ClosingDisclosure |
 | 57  | 53           | PrepaidCharges | 35           | ClosingDisclosure |

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
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |	

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |


@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |

@NoPrepaid
@WithPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, with PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
 And user have variable loan data from excel sheet <aSheetName> for the scenario <aScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
Examples: 
| No    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | aScenarioNo | aSheetName |
| 1R    | 2            | MortgageInsurance | 2            | ClosingDisclosure | 1           | ARM Terms  |
| 2R    | 3            | MortgageInsurance | 3            | ClosingDisclosure | 1           | ARM Terms  |
| 3R    | 4            | MortgageInsurance | 4            | ClosingDisclosure | 1           | ARM Terms  |
| 4R    | 5            | MortgageInsurance | 5            | ClosingDisclosure | 1           | ARM Terms  |
| 6R    | 6            | MortgageInsurance | 6            | ClosingDisclosure | 1           | ARM Terms  |
| 7R    | 7            | MortgageInsurance | 7            | ClosingDisclosure | 1           | ARM Terms  |
| 8R    | 8            | MortgageInsurance | 8            | ClosingDisclosure | 1           | ARM Terms  |
| 9R    | 9            | MortgageInsurance | 9            | ClosingDisclosure | 1           | ARM Terms  |
| 11R   | 10           | MortgageInsurance | 10           | ClosingDisclosure | 1           | ARM Terms  |
| 12R   | 11           | MortgageInsurance | 11           | ClosingDisclosure | 1           | ARM Terms  |
| 13R   | 12           | MortgageInsurance | 12           | ClosingDisclosure | 1           | ARM Terms  |
| 14R   | 13           | MortgageInsurance | 13           | ClosingDisclosure | 1           | ARM Terms  |
| 16R   | 14           | MortgageInsurance | 14           | ClosingDisclosure | 1           | ARM Terms  |
| 17R   | 15           | MortgageInsurance | 15           | ClosingDisclosure | 1           | ARM Terms  |
| 19R   | 16           | MortgageInsurance | 16           | ClosingDisclosure | 1           | ARM Terms  |
| 36R   | 17           | MortgageInsurance | 17           | ClosingDisclosure | 2           | ARM Terms  |
| 37R   | 18           | MortgageInsurance | 18           | ClosingDisclosure | 3           | ARM Terms  |
| 38R   | 19           | MortgageInsurance | 19           | ClosingDisclosure | 4           | ARM Terms  |
| 38.1R | 20           | MortgageInsurance | 20           | ClosingDisclosure | 5           | ARM Terms  |



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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed pmi value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Drop off years for PMI value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total Period Payment value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed APR value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Balloon Amount value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Total of Payments value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Finance Charge value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Prepaid Charges value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Amount Financed value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Escrow Property Costs over one year value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed TIP value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Initial Escrow Payment value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Period Escrow Payment value should display on Closing Disclosure
Examples: 
| No  | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       |
| 39R | 21           | MortgageInsurance | 21           | ClosingDisclosure |

#============================================================================================================================ 
#================================ Closing Disclosure with No Prepaid, No PMI, With Escrow ===================================
#============================================================================================================================ 

@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Principal and Interest card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |
	


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |


@NoPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with No Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | cdScenarioNo | cdSheetName       |
| 40R | 22           | ClosingDisclosure |



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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |



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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |

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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| 42R | 43           | PrepaidCharges | 24           | MortgageInsurance | 24           | ClosingDisclosure |
| 70  | 63           | PrepaidCharges | 27           | MortgageInsurance | 46           | ClosingDisclosure |
| 71  | 64           | PrepaidCharges | 28           | MortgageInsurance | 47           | ClosingDisclosure |
| 72  | 65           | PrepaidCharges | 29           | MortgageInsurance | 48           | ClosingDisclosure |
| 73  | 66           | PrepaidCharges | 30           | MortgageInsurance | 49           | ClosingDisclosure |
| 74  | 67           | PrepaidCharges | 31           | MortgageInsurance | 50           | ClosingDisclosure |
| 75  | 68           | PrepaidCharges | 32           | MortgageInsurance | 51           | ClosingDisclosure |
| 76  | 69           | PrepaidCharges | 33           | MortgageInsurance | 52           | ClosingDisclosure |
| 77  | 70           | PrepaidCharges | 34           | MortgageInsurance | 53           | ClosingDisclosure |


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
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |
	


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating PMI card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Drop off years for PMI card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total Period Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating APR card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Balloon Amount card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Total of Payments card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Finance Charge card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Prepaid Charges card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Amount Financed card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating TIP card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Initial Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |


@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Non Escrow Property Costs over one year card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |

@WithPrepaid
@NoPMI
@WithEscrow
Scenario Outline: Validating Period Escrow Payment card value on Closing Disclosure page with Prepaid, No PMI, with Escrow
Given user is at TRID application homepage
 And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
 And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
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
| No  | pcScenarioNo | pcSheetName    | cdScenarioNo | cdSheetName       |
| 43R | 44           | PrepaidCharges | 25           | ClosingDisclosure |