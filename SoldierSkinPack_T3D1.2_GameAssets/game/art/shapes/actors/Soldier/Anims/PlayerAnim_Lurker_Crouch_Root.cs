singleton TSShapeConstructor(PlayerAnim_Lurker_Crouch_RootDAE)
{
   baseShape = "./PlayerAnim_Lurker_Crouch_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "300", "359");
}
