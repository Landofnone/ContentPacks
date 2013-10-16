singleton TSShapeConstructor(PlayerAnim_Lurker_Swim_LeftDAE)
{
   baseShape = "./PlayerAnim_Lurker_Swim_Left.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1670", "1729");
}
