singleton TSShapeConstructor(PlayerAnim_Lurker_RunDAE)
{
   baseShape = "./PlayerAnim_Lurker_Run.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "150", "169");
}
