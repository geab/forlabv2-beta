
--table ForlabParameters values
INSERT [ForlabParameters] ([ParmName], [ParmValue]) VALUES (N'RulesBothNegative', N'Proceed')
GO
INSERT [ForlabParameters] ([ParmName], [ParmValue]) VALUES (N'RulesBothPositive', N'Proceed')
GO
INSERT [ForlabParameters] ([ParmName], [ParmValue]) VALUES (N'RulesDiscordant', N'Proceed')
GO
INSERT [ForlabParameters] ([ParmName], [ParmValue]) VALUES (N'version', N'2.0.0')
GO
--table QuantifyMenu values
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','Total_Positive_Diagnoses','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','Total_Positive_Diagnoses_to_Receive_CD4','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','Total_Blood_Draws','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','Blood_Draws_Adult','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','Blood_Draws_Pediatric','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','PerDay_PerSite','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','PerWeek_PerSite','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','PerMonth_PerSite','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','PerQuarter_PerSite','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('Consumable','PerYear_PerSite','General')
GO

INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Rapid_Tests','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Screenings','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Confirmatory_Tests','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Tie_Breaker_Tests','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Screenings_Plus_Confirmatory','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Confirmatory_Plus_Tie_Breaker','General')
GO
INSERT INTO QuantifyMenu (ClassOfTest,Title,TestType) VALUES ('RapidTest','Total_Screenings_Plus_Tie_Breaker','General')
GO

--table protocol values
DECLARE @protocolid int
INSERT INTO Protocol(ProtocolType,TestReapeated, SymptomDirectedAmt,Descritpion)VALUES (1,0,0,N'')
SELECT @protocolid = Scope_Identity()

INSERT ProtocolPanel (ProtocolId, PanelName, AITNewPatient, AITPreExisting, AITTestperYear, AITMonth1, AITMonth2, AITMonth3, AITMonth4, AITMonth5, AITMonth6, AITMonth7, AITMonth8, AITMonth9, AITMonth10, AITMonth11, AITMonth12, PITNewPatient, PITPreExisting, PITTestperYear, PITMonth1, PITMonth2, PITMonth3, PITMonth4, PITMonth5, PITMonth6, PITMonth7, PITMonth8, PITMonth9, PITMonth10, PITMonth11, PITMonth12, APARTNewPatient, APARTPreExisting, APARTestperYear, APARTMonth1, APARTMonth2, APARTMonth3, APARTMonth4, APARTMonth5, APARTMonth6, APARTMonth7, APARTMonth8, APARTMonth9, APARTMonth10, APARTMonth11, APARTMonth12, PPARTNewPatient, PPARTPreExisting, PPARTTestperYear, PPARTMonth1, PPARTMonth2, PPARTMonth3, PPARTMonth4, PPARTMonth5, PPARTMonth6, PPARTMonth7, PPARTMonth8, PPARTMonth9, PPARTMonth10, PPARTMonth11, PPARTMonth12) VALUES (@protocolid, N'CD4 Panel', 0, 0, 2, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1)
GO

INSERT INTO Protocol(ProtocolType,TestReapeated, SymptomDirectedAmt,Descritpion)VALUES (2, 0, 0, N'')
INSERT INTO Protocol(ProtocolType,TestReapeated, SymptomDirectedAmt,Descritpion)VALUES(3, 0, 0, N'')
INSERT INTO Protocol(ProtocolType,TestReapeated, SymptomDirectedAmt,Descritpion)VALUES(4, 0, 0, N'')
INSERT INTO Protocol(ProtocolType,TestReapeated, SymptomDirectedAmt,Descritpion)VALUES(5, 0, 0, N'')
GO