using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System2 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component410> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
  }
 }
}

}
