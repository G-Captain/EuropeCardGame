﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyModel {


    public ArmyCardsModel armyCardsModel;
    public Town town;

    public ArmyModel(Faction faction)
    {
        if (faction == Faction.Ottoman)
        {
            this.armyCardsModel = new ArmyCardsModel();
            //this.town = new Town(0, "Istambul", "greatest town", 40);
            //this.town.name.text = "Istanbul";
        }
        else
        {
            this.armyCardsModel = new ArmyCardsModel();
            //this.town = new Town(0, "Warsaw", "strongest town", 45);
        }

    }


}
