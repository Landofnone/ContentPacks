singleton TSShapeConstructor(PlayerAnim_Lurker_Swim_BackwardDAE)
{
   baseShape = "./PlayerAnim_Lurker_Swim_Backward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Swim_BackwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Backward", "1580", "1639");
}
