singleton TSShapeConstructor(PlayerAnim_Lurker_SideDAE)
{
   baseShape = "./PlayerAnim_Lurker_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "200", "219");
}
