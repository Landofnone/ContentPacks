singleton TSShapeConstructor(PlayerAnim_Lurker_Crouch_ForwardDAE)
{
   baseShape = "./PlayerAnim_Lurker_Crouch_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "400", "429");
}
