%{
	public GameNode root;

    public Parser(AbstractScanner<ValueType, LexLocation> scanner, string patternGame) : base(scanner) 
	{
		this.root = new GameNode(patternGame);
	}
%}

%output = ../../YaccLex/SimpleYacc.cs

%union { 
			public string sVal;

			public SpritesInitNode spsIVal;
			public SpriteInitNode spIVal;
			public List<SpriteInitNode> lstSIVal;
			public AssignNode singVal;
			public List<AssignNode> lstSingVal;
			public List<Type> lstBVal;
			public Type typeVal;

			public VariablesInitNode vInitVal;
			public InitializeNode initVal;
			public UpdateNode upVal;
       }

%using GameLangParser.Nodes;
%namespace GameLangParser

%token BLOCKBEGIN BLOCKEND SEMICOLON OPBRACKET CLBRACKET VAR COMMA OPPARENTHESES CLPARENTHESES ASSIGN NEW 
%token SEMICOLON DOT
%token <sVal> CODEBLOCK BLOCKSPRITESINIT BLOCKVARIBLESINIT BLOCKLOADCONTENT BLOCKINITIALIZE BLOCKUPDATE ID STRING FIELD INTNUM
%token <typeVal> BEHAVIOUR

%type <spsIVal> blockSpritesInit
%type <spIVal> spriteInit
%type <lstSIVal> spritesInit
%type <lstBVal> behaviours

%type <lstSingVal> initList
%type <singVal> assign

%type <vInitVal> blockVariablesInit
%type <initVal> blockInitialize
%type <upVal> blockUpdate
%type <sVal> funtionality operAssign newParams id

%%

progr   :  blockSpritesInit blockVariablesInit blockInitialize blockUpdate 
		{ root.AddNode($1); root.AddNode($2); root.AddNode($3); root.AddNode($4);}
		;
		
blockSpritesInit	: BLOCKSPRITESINIT BLOCKBEGIN spritesInit BLOCKEND
					{ 
						$$ = new SpritesInitNode(null, $1);
						$$.inits = $3;
					}
					;

spritesInit : spriteInit 
			{
				$$ = new List<SpriteInitNode>();
				$$.Add($1);
			}
			| spritesInit spriteInit
			{
				$1.Add($2);
				$$ = $1;
			}
			;

spriteInit	: ID ASSIGN OPPARENTHESES behaviours CLPARENTHESES
			{
				$$ = new SpriteInitNode($1);
				$$.behaviours = $4;
			}
			;

behaviours	: BEHAVIOUR 
			{
				$$ = new List<Type>();
				$$.Add($1);
			}
			| behaviours COMMA BEHAVIOUR
			{
				$1.Add($3);
				$$ = $1;
			}
			;


blockVariablesInit: BLOCKVARIBLESINIT BLOCKBEGIN funtionality BLOCKEND 
		{ $$ = new VariablesInitNode($3, $1); }
		;

blockInitialize	: BLOCKINITIALIZE BLOCKBEGIN initList SEMICOLON BLOCKEND 
				{ $$ = new InitializeNode(null, $1); $$.assings = $3;}
				;

initList	: assign 
			{
				$$ = new List<AssignNode>();
				$$.Add($1);
			}
			| initList SEMICOLON assign 
			{
				$1.Add($3);
				$$ = $1;
			}
			;

assign		: id ASSIGN operAssign
			{
				$$ = new AssignNode($1, $3);
			}
			| id ASSIGN NEW id OPBRACKET STRING newParams CLBRACKET
			{
				$$ = new AssignNode($1, $4, $6, $7);
			}
			;

newParams	: COMMA INTNUM COMMA INTNUM
			{
				$$ = ',' + $2 + ',' + $4;
			}
			;

operAssign	: INTNUM
			{
				$$ = $1;
			}
			| STRING
			{
				$$ = $1;
			}
			| id
			{
				$$ = $1;
			}
			;

id			: ID
			{
				$$ = $1;
			}
			| FIELD
			{
				$$ = $1;
			}
			;

blockUpdate		 : BLOCKUPDATE BLOCKBEGIN funtionality BLOCKEND 
		{ $$ = new UpdateNode($3, $1);}
		;

funtionality	 : CODEBLOCK
		{ $$ = $1; }
		;
%%
