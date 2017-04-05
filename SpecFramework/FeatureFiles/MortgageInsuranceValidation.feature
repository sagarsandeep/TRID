Feature: MortgageInsuranceValidation
#The Payment Schedule is recalculated and show in the same page.
#The Drop off years for PMI changes


@MortgageInsurance
@GiveInput
Scenario Outline: Enter PMI rate data and validate Pmi Grid in Mortgage Insurance Page
Given user is at TRID application homepage
	And user navigate to Closing Disclosure Page
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then Pmi Rates Grid should have inserted values
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate PMI card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user navigate to Closing Disclosure Page
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed pmi value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate Drop off years for PMI card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed Drop off years for PMI value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate Total Period Payment card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed Total Period Payment value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate Total Of Payments card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed Total Of Payments value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate Amount Financed card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed Amount Financed value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

@MortgageInsurance
@GiveInput
Scenario Outline: Validate APR card value in Mortgage Insurance Page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Closing Disclosure Page
	And user selects Calculation Method
	And user selects loan type 
	And user selects Frequency of Payments 
	And user selects Loan Term 
	And user selects Repayment Term Type 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user enter input value for Lower Of Cost Or Appraisal
	And user clicks on Mortgage Insurance Test Button
Then updated/computed APR value should display on Mortgage Insurance
Examples:
	| No | cdScenarioNo | cdSheetName       | miScenarioNo | miSheetName       |
	| 1  | 1            | ClosingDisclosure | 1            | MortgageInsurance |
	| 2  | 1            | ClosingDisclosure | 2            | MortgageInsurance |
	| 3  | 1            | ClosingDisclosure | 3            | MortgageInsurance |
	| 4  | 1            | ClosingDisclosure | 4            | MortgageInsurance |
	| 5  | 1            | ClosingDisclosure | 5            | MortgageInsurance |

