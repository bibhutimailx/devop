


lambda_apigw_dotnet
-------------------

Crea un Lambda en Net Core y un API Gateway.

Para compilar ejecuta: ./build.sh



## Permisos

```
GBMAWSCloudFormationExecutionPolicy:


- Effect: Allow
  Action:
  - lambda:Get*
  - lambda:List*
  - lambda:CreateAlias
  - lambda:CreateFunction
  - lambda:PublishVersion
  - lambda:AddPermission
  - lambda:PutFunctionConcurrency
  - lambda:Update*
  - lambda:RemovePermission
  - lambda:Delete*
  - lambda:TagResource
  - lambda:UntagResource
  Resource:
  - Fn::Sub: arn:aws:lambda:*:${AWS::AccountId}:function:lambda-apigw-python-*
- Effect: Allow
  Action:
  - iam:PassRole
  Resource:
  # Note: use the role for your function here. Ex: GBMAWSLambdaExecutionRole
  - Fn::Sub: arn:aws:iam::${AWS::AccountId}:role/GBMA*
- Effect: Allow
  Action:
  - logs:*LogGroup*
  - logs:*LogStream*
  - logs:*LogEvents*
  - logs:*Subscription*
  - logs:*RetentionPolicy
  Resource:
  - Fn::Sub: arn:aws:logs:us-east-1:${AWS::AccountId}:*:*
- Effect: Allow
  Action:
  - apigateway:GET
  Resource:
  - arn:aws:apigateway:us-east-1::/restapis*
  - arn:aws:apigateway:us-east-1::/usageplans*
```





