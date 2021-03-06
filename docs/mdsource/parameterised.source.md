# Parameterised Tests

## Additions to file name

Every parameterised case has a unique file name the arguments are appended to the [file name](/docs/naming.md).

The appending format is `_ArgName=ArgValue` repeated for each arg. 

A test with two parameters `param1` + `param2`, and called twice with the values `value1a`+ `value2a` and `value1b`+ `value2b` would have the following file names:

  * `MyTest.MyMethod_param1=value1a_param2=value2a.verified.txt`
  * `MyTest.MyMethod_param1=value1b_param2=value2b.verified.txt`


## xUnit


### InlineData

snippet: xunitInlineData


### MemberData

snippet: xunitMemberData


## NUnit


### TestCase

snippet: NUnitTestCase


## MSTest

MSTest does not expose the parameter values via its extensibility context. So parameter values must passed in via settings.


### DataRow

snippet: MSTestDataRow