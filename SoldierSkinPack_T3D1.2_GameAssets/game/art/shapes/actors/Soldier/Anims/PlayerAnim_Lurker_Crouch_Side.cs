singleton TSShapeConstructor(PlayerAnim_Lurker_Crouch_SideDAE)
{
   baseShape = "./PlayerAnim_Lurker_Crouch_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "520", "549");
}
