singleton TSShapeConstructor(PlayerAnim_Lurker_Swim_ForwardDAE)
{
   baseShape = "./PlayerAnim_Lurker_Swim_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1490", "1549");
}
