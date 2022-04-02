using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System130 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component374,Component434,Component274,Component117> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
  }
 }
}

}
