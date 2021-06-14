// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-KDBR5P2
// DateTime: 14.06.2021 14:54:43
// UserName: User
// Input file <../../YaccLex/SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using GameLangParser.Nodes;

namespace GameLangParser
{
public enum Tokens {
    error=1,EOF=2,BLOCKBEGIN=3,BLOCKEND=4,SEMICOLON=5,OPBRACKET=6,
    CLBRACKET=7,VAR=8,COMMA=9,OPPARENTHESES=10,CLPARENTHESES=11,ASSIGN=12,
    NEW=13,EQUAL=14,DOT=15,CODEBLOCK=16,BLOCKSPRITESINIT=17,BLOCKVARIBLESINIT=18,
    BLOCKLOADCONTENT=19,BLOCKINITIALIZE=20,BLOCKUPDATE=21,ID=22,STRING=23,FIELD=24,
    INTNUM=25,INTTYPE=26,STRINGTYPE=27,TEXTBOX=28,ADD=29,SUBSTRACT=30,
    MULTIPLY=31,DIVIDE=32,BEHAVIOUR=33};

public struct ValueType
{ 
			public string sVal;

			public SpritesInitNode spsIVal;
			public SpriteInitNode spIVal;
			public List<SpriteInitNode> lstSIVal;
			public AssignNode singVal;
			public List<AssignNode> lstSingVal;
			public VarNode varVal;
			public List<VarNode> lstvarVal;
			public List<Type> lstBVal;
			public Type typeVal;

			public VariablesInitNode vInitVal;
			public InitializeNode initVal;
			public UpdateNode upVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from ../../YaccLex/SimpleYacc.y
	public GameNode root;

    public Parser(AbstractScanner<ValueType, LexLocation> scanner, string patternGame) : base(scanner) 
	{
		this.root = new GameNode(patternGame);
	}
  // End verbatim content from ../../YaccLex/SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[45];
  private static State[] states = new State[105];
  private static string[] nonTerms = new string[] {
      "blockSpritesInit", "spriteInit", "spritesInit", "behaviours", "blockInitialize", 
      "initList", "assign", "blockVariablesInit", "assignOrVar", "assignVariable", 
      "variable", "variablesList", "variablesSprite", "blockUpdate", "funtionality", 
      "id", "newParams", "expression", "T", "F", "progr", "$accept", };

  static Parser() {
    states[0] = new State(new int[]{17,77},new int[]{-21,1,-1,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{18,58},new int[]{-8,4});
    states[4] = new State(new int[]{20,12},new int[]{-5,5});
    states[5] = new State(new int[]{21,7},new int[]{-14,6});
    states[6] = new State(-2);
    states[7] = new State(new int[]{3,8});
    states[8] = new State(new int[]{16,11},new int[]{-15,9});
    states[9] = new State(new int[]{4,10});
    states[10] = new State(-43);
    states[11] = new State(-44);
    states[12] = new State(new int[]{3,13});
    states[13] = new State(new int[]{22,53,24,54},new int[]{-6,14,-7,57,-16,18});
    states[14] = new State(new int[]{5,15});
    states[15] = new State(new int[]{4,16,22,53,24,54},new int[]{-7,17,-16,18});
    states[16] = new State(-22);
    states[17] = new State(-24);
    states[18] = new State(new int[]{14,19});
    states[19] = new State(new int[]{13,34,23,55,22,25,24,26,25,27},new int[]{-18,20,-19,56,-20,31});
    states[20] = new State(new int[]{29,21,30,32,5,-25});
    states[21] = new State(new int[]{22,25,24,26,25,27,23,28},new int[]{-19,22,-20,31});
    states[22] = new State(new int[]{31,23,32,29,29,-32,30,-32,5,-32});
    states[23] = new State(new int[]{22,25,24,26,25,27,23,28},new int[]{-20,24});
    states[24] = new State(-35);
    states[25] = new State(-37);
    states[26] = new State(-38);
    states[27] = new State(-39);
    states[28] = new State(-40);
    states[29] = new State(new int[]{22,25,24,26,25,27,23,28},new int[]{-20,30});
    states[30] = new State(-36);
    states[31] = new State(-34);
    states[32] = new State(new int[]{22,25,24,26,25,27,23,28},new int[]{-19,33,-20,31});
    states[33] = new State(new int[]{31,23,32,29,29,-33,30,-33,5,-33});
    states[34] = new State(new int[]{28,49,22,53,24,54},new int[]{-16,35});
    states[35] = new State(new int[]{6,36});
    states[36] = new State(new int[]{23,37});
    states[37] = new State(new int[]{9,40,25,44},new int[]{-17,38});
    states[38] = new State(new int[]{7,39});
    states[39] = new State(-26);
    states[40] = new State(new int[]{25,41});
    states[41] = new State(new int[]{9,42});
    states[42] = new State(new int[]{25,43});
    states[43] = new State(-29);
    states[44] = new State(new int[]{9,45});
    states[45] = new State(new int[]{25,46});
    states[46] = new State(new int[]{9,47});
    states[47] = new State(new int[]{23,48});
    states[48] = new State(-30);
    states[49] = new State(new int[]{6,50});
    states[50] = new State(new int[]{9,40,25,44},new int[]{-17,51});
    states[51] = new State(new int[]{7,52});
    states[52] = new State(-27);
    states[53] = new State(-41);
    states[54] = new State(-42);
    states[55] = new State(new int[]{5,-28,31,-40,32,-40,29,-40,30,-40});
    states[56] = new State(new int[]{31,23,32,29,29,-31,30,-31,5,-31});
    states[57] = new State(-23);
    states[58] = new State(new int[]{3,59});
    states[59] = new State(new int[]{26,65,27,69,22,74},new int[]{-12,60,-9,76,-10,64,-11,73});
    states[60] = new State(new int[]{5,61});
    states[61] = new State(new int[]{4,62,26,65,27,69,22,74},new int[]{-9,63,-10,64,-11,73});
    states[62] = new State(-12);
    states[63] = new State(-14);
    states[64] = new State(-15);
    states[65] = new State(new int[]{22,66});
    states[66] = new State(new int[]{14,67,5,-19});
    states[67] = new State(new int[]{25,68});
    states[68] = new State(-17);
    states[69] = new State(new int[]{22,70});
    states[70] = new State(new int[]{14,71,5,-20});
    states[71] = new State(new int[]{23,72});
    states[72] = new State(-18);
    states[73] = new State(-16);
    states[74] = new State(new int[]{22,75});
    states[75] = new State(-21);
    states[76] = new State(-13);
    states[77] = new State(new int[]{3,78});
    states[78] = new State(new int[]{22,82},new int[]{-3,79,-2,104});
    states[79] = new State(new int[]{4,80,22,82},new int[]{-2,81});
    states[80] = new State(-3);
    states[81] = new State(-5);
    states[82] = new State(new int[]{12,83,6,90});
    states[83] = new State(new int[]{10,84});
    states[84] = new State(new int[]{33,89},new int[]{-4,85});
    states[85] = new State(new int[]{11,86,9,87});
    states[86] = new State(-6);
    states[87] = new State(new int[]{33,88});
    states[88] = new State(-11);
    states[89] = new State(-10);
    states[90] = new State(new int[]{26,99,27,101},new int[]{-13,91,-10,103});
    states[91] = new State(new int[]{5,92});
    states[92] = new State(new int[]{7,93,26,99,27,101},new int[]{-10,98});
    states[93] = new State(new int[]{12,94});
    states[94] = new State(new int[]{10,95});
    states[95] = new State(new int[]{33,89},new int[]{-4,96});
    states[96] = new State(new int[]{11,97,9,87});
    states[97] = new State(-7);
    states[98] = new State(-9);
    states[99] = new State(new int[]{22,100});
    states[100] = new State(new int[]{14,67});
    states[101] = new State(new int[]{22,102});
    states[102] = new State(new int[]{14,71});
    states[103] = new State(-8);
    states[104] = new State(-4);

    rules[1] = new Rule(-22, new int[]{-21,2});
    rules[2] = new Rule(-21, new int[]{-1,-8,-5,-14});
    rules[3] = new Rule(-1, new int[]{17,3,-3,4});
    rules[4] = new Rule(-3, new int[]{-2});
    rules[5] = new Rule(-3, new int[]{-3,-2});
    rules[6] = new Rule(-2, new int[]{22,12,10,-4,11});
    rules[7] = new Rule(-2, new int[]{22,6,-13,5,7,12,10,-4,11});
    rules[8] = new Rule(-13, new int[]{-10});
    rules[9] = new Rule(-13, new int[]{-13,5,-10});
    rules[10] = new Rule(-4, new int[]{33});
    rules[11] = new Rule(-4, new int[]{-4,9,33});
    rules[12] = new Rule(-8, new int[]{18,3,-12,5,4});
    rules[13] = new Rule(-12, new int[]{-9});
    rules[14] = new Rule(-12, new int[]{-12,5,-9});
    rules[15] = new Rule(-9, new int[]{-10});
    rules[16] = new Rule(-9, new int[]{-11});
    rules[17] = new Rule(-10, new int[]{26,22,14,25});
    rules[18] = new Rule(-10, new int[]{27,22,14,23});
    rules[19] = new Rule(-11, new int[]{26,22});
    rules[20] = new Rule(-11, new int[]{27,22});
    rules[21] = new Rule(-11, new int[]{22,22});
    rules[22] = new Rule(-5, new int[]{20,3,-6,5,4});
    rules[23] = new Rule(-6, new int[]{-7});
    rules[24] = new Rule(-6, new int[]{-6,5,-7});
    rules[25] = new Rule(-7, new int[]{-16,14,-18});
    rules[26] = new Rule(-7, new int[]{-16,14,13,-16,6,23,-17,7});
    rules[27] = new Rule(-7, new int[]{-16,14,13,28,6,-17,7});
    rules[28] = new Rule(-7, new int[]{-16,14,23});
    rules[29] = new Rule(-17, new int[]{9,25,9,25});
    rules[30] = new Rule(-17, new int[]{25,9,25,9,23});
    rules[31] = new Rule(-18, new int[]{-19});
    rules[32] = new Rule(-18, new int[]{-18,29,-19});
    rules[33] = new Rule(-18, new int[]{-18,30,-19});
    rules[34] = new Rule(-19, new int[]{-20});
    rules[35] = new Rule(-19, new int[]{-19,31,-20});
    rules[36] = new Rule(-19, new int[]{-19,32,-20});
    rules[37] = new Rule(-20, new int[]{22});
    rules[38] = new Rule(-20, new int[]{24});
    rules[39] = new Rule(-20, new int[]{25});
    rules[40] = new Rule(-20, new int[]{23});
    rules[41] = new Rule(-16, new int[]{22});
    rules[42] = new Rule(-16, new int[]{24});
    rules[43] = new Rule(-14, new int[]{21,3,-15,4});
    rules[44] = new Rule(-15, new int[]{16});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> blockSpritesInit, blockVariablesInit, blockInitialize, blockUpdate
{ root.AddNode(ValueStack[ValueStack.Depth-4].spsIVal); root.AddNode(ValueStack[ValueStack.Depth-3].vInitVal); root.AddNode(ValueStack[ValueStack.Depth-2].initVal); root.AddNode(ValueStack[ValueStack.Depth-1].upVal);}
        break;
      case 3: // blockSpritesInit -> BLOCKSPRITESINIT, BLOCKBEGIN, spritesInit, BLOCKEND
{ 
						CurrentSemanticValue.spsIVal = new SpritesInitNode(null, ValueStack[ValueStack.Depth-4].sVal);
						CurrentSemanticValue.spsIVal.inits = ValueStack[ValueStack.Depth-2].lstSIVal;
					}
        break;
      case 4: // spritesInit -> spriteInit
{
				CurrentSemanticValue.lstSIVal = new List<SpriteInitNode>();
				CurrentSemanticValue.lstSIVal.Add(ValueStack[ValueStack.Depth-1].spIVal);
			}
        break;
      case 5: // spritesInit -> spritesInit, spriteInit
{
				ValueStack[ValueStack.Depth-2].lstSIVal.Add(ValueStack[ValueStack.Depth-1].spIVal);
				CurrentSemanticValue.lstSIVal = ValueStack[ValueStack.Depth-2].lstSIVal;
			}
        break;
      case 6: // spriteInit -> ID, ASSIGN, OPPARENTHESES, behaviours, CLPARENTHESES
{
				CurrentSemanticValue.spIVal = new SpriteInitNode(ValueStack[ValueStack.Depth-5].sVal);
				CurrentSemanticValue.spIVal.behaviours = ValueStack[ValueStack.Depth-2].lstBVal;
			}
        break;
      case 7: // spriteInit -> ID, OPBRACKET, variablesSprite, SEMICOLON, CLBRACKET, ASSIGN, 
              //               OPPARENTHESES, behaviours, CLPARENTHESES
{
				CurrentSemanticValue.spIVal = new SpriteInitNode(ValueStack[ValueStack.Depth-9].sVal);
				CurrentSemanticValue.spIVal.behaviours = ValueStack[ValueStack.Depth-2].lstBVal;
				CurrentSemanticValue.spIVal.variables = ValueStack[ValueStack.Depth-7].lstvarVal;
			}
        break;
      case 8: // variablesSprite -> assignVariable
{
					CurrentSemanticValue.lstvarVal = new List<VarNode>();
					CurrentSemanticValue.lstvarVal.Add(ValueStack[ValueStack.Depth-1].varVal);
				}
        break;
      case 9: // variablesSprite -> variablesSprite, SEMICOLON, assignVariable
{
					ValueStack[ValueStack.Depth-3].lstvarVal.Add(ValueStack[ValueStack.Depth-1].varVal);
					CurrentSemanticValue.lstvarVal = ValueStack[ValueStack.Depth-3].lstvarVal;
				}
        break;
      case 10: // behaviours -> BEHAVIOUR
{
				CurrentSemanticValue.lstBVal = new List<Type>();
				CurrentSemanticValue.lstBVal.Add(ValueStack[ValueStack.Depth-1].typeVal);
			}
        break;
      case 11: // behaviours -> behaviours, COMMA, BEHAVIOUR
{
				ValueStack[ValueStack.Depth-3].lstBVal.Add(ValueStack[ValueStack.Depth-1].typeVal);
				CurrentSemanticValue.lstBVal = ValueStack[ValueStack.Depth-3].lstBVal;
			}
        break;
      case 12: // blockVariablesInit -> BLOCKVARIBLESINIT, BLOCKBEGIN, variablesList, SEMICOLON, 
               //                       BLOCKEND
{ CurrentSemanticValue.vInitVal = new VariablesInitNode(null, ValueStack[ValueStack.Depth-5].sVal);  CurrentSemanticValue.vInitVal.varNodes = ValueStack[ValueStack.Depth-3].lstvarVal;}
        break;
      case 13: // variablesList -> assignOrVar
{
					CurrentSemanticValue.lstvarVal = new List<VarNode>();
					CurrentSemanticValue.lstvarVal.Add(ValueStack[ValueStack.Depth-1].varVal);
				}
        break;
      case 14: // variablesList -> variablesList, SEMICOLON, assignOrVar
{
					ValueStack[ValueStack.Depth-3].lstvarVal.Add(ValueStack[ValueStack.Depth-1].varVal);
					CurrentSemanticValue.lstvarVal = ValueStack[ValueStack.Depth-3].lstvarVal;
				}
        break;
      case 15: // assignOrVar -> assignVariable
{ CurrentSemanticValue.varVal = ValueStack[ValueStack.Depth-1].varVal; }
        break;
      case 16: // assignOrVar -> variable
{ CurrentSemanticValue.varVal = ValueStack[ValueStack.Depth-1].varVal; }
        break;
      case 17: // assignVariable -> INTTYPE, ID, EQUAL, INTNUM
{ CurrentSemanticValue.varVal = new VarNode(ValueStack[ValueStack.Depth-4].sVal, ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 18: // assignVariable -> STRINGTYPE, ID, EQUAL, STRING
{ CurrentSemanticValue.varVal = new VarNode(ValueStack[ValueStack.Depth-4].sVal, ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 19: // variable -> INTTYPE, ID
{ CurrentSemanticValue.varVal = new VarNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 20: // variable -> STRINGTYPE, ID
{ CurrentSemanticValue.varVal = new VarNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 21: // variable -> ID, ID
{ CurrentSemanticValue.varVal = new VarNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 22: // blockInitialize -> BLOCKINITIALIZE, BLOCKBEGIN, initList, SEMICOLON, BLOCKEND
{ CurrentSemanticValue.initVal = new InitializeNode(null, ValueStack[ValueStack.Depth-5].sVal); CurrentSemanticValue.initVal.assings = ValueStack[ValueStack.Depth-3].lstSingVal;}
        break;
      case 23: // initList -> assign
{
				CurrentSemanticValue.lstSingVal = new List<AssignNode>();
				CurrentSemanticValue.lstSingVal.Add(ValueStack[ValueStack.Depth-1].singVal);
			}
        break;
      case 24: // initList -> initList, SEMICOLON, assign
{
				ValueStack[ValueStack.Depth-3].lstSingVal.Add(ValueStack[ValueStack.Depth-1].singVal);
				CurrentSemanticValue.lstSingVal = ValueStack[ValueStack.Depth-3].lstSingVal;
			}
        break;
      case 25: // assign -> id, EQUAL, expression
{
				CurrentSemanticValue.singVal = new AssignNode(ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-1].sVal);
			}
        break;
      case 26: // assign -> id, EQUAL, NEW, id, OPBRACKET, STRING, newParams, CLBRACKET
{
				CurrentSemanticValue.singVal = new AssignNode(ValueStack[ValueStack.Depth-8].sVal, ValueStack[ValueStack.Depth-5].sVal, ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal);
			}
        break;
      case 27: // assign -> id, EQUAL, NEW, TEXTBOX, OPBRACKET, newParams, CLBRACKET
{
				CurrentSemanticValue.singVal = new AssignNode(ValueStack[ValueStack.Depth-7].sVal, ValueStack[ValueStack.Depth-4].sVal, ValueStack[ValueStack.Depth-2].sVal);
			}
        break;
      case 28: // assign -> id, EQUAL, STRING
{
				CurrentSemanticValue.singVal = new AssignNode(ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-1].sVal);
			}
        break;
      case 29: // newParams -> COMMA, INTNUM, COMMA, INTNUM
{
				CurrentSemanticValue.sVal = ',' + ValueStack[ValueStack.Depth-3].sVal + ',' + ValueStack[ValueStack.Depth-1].sVal;
			}
        break;
      case 30: // newParams -> INTNUM, COMMA, INTNUM, COMMA, STRING
{
				CurrentSemanticValue.sVal = ',' + ValueStack[ValueStack.Depth-5].sVal + ',' + ValueStack[ValueStack.Depth-3].sVal + ',' + ValueStack[ValueStack.Depth-1].sVal;
			}
        break;
      case 31: // expression -> T
{CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal;}
        break;
      case 32: // expression -> expression, ADD, T
{CurrentSemanticValue.sVal = string.Format("{0} {1} {2}", ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal);}
        break;
      case 33: // expression -> expression, SUBSTRACT, T
{CurrentSemanticValue.sVal = string.Format("{0} {1} {2}", ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal);}
        break;
      case 34: // T -> F
{CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal;}
        break;
      case 35: // T -> T, MULTIPLY, F
{CurrentSemanticValue.sVal = string.Format("{0} {1} {2}", ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal);}
        break;
      case 36: // T -> T, DIVIDE, F
{CurrentSemanticValue.sVal = string.Format("{0} {1} {2}", ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal);}
        break;
      case 37: // F -> ID
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
      case 38: // F -> FIELD
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
      case 39: // F -> INTNUM
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
      case 40: // F -> STRING
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
      case 41: // id -> ID
{
				CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal;
			}
        break;
      case 42: // id -> FIELD
{
				CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal;
			}
        break;
      case 43: // blockUpdate -> BLOCKUPDATE, BLOCKBEGIN, funtionality, BLOCKEND
{ CurrentSemanticValue.upVal = new UpdateNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-4].sVal);}
        break;
      case 44: // funtionality -> CODEBLOCK
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
