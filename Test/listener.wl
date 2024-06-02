(*errors:-1 for closing,0 for OK,1 for unevaluable expression*)

SendResponse[client_, error_, result_] := 
 WriteString[client, 
  StringJoin["{\"Error\":", error, ", \"Data\":\"", 
   ToString[result, InputForm], "\"}"]]
Close[server]

handler[assoc_Association] :=  Module[{client, request, svg},
    client = assoc["SourceSocket"];
    request = ByteArrayToString[assoc["DataByteArray"]];
    Echo[request, "Received "];
    If[SyntaxQ[request], 
       SendResponse[client, "0", ToExpression[request]],
       SendResponse[client, "-1", 
    "Cannot evaluate expression" <> request]
     ]
  ]

listener = SocketListen[7734, handler]
server = listener["Socket"]
Pause[1000000]