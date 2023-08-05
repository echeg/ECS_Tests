using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System128 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component52,Component163,Component150,Component177> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component360>())
   {
    entity.Del<Component360>();
   }
   else
   {
    entity.Replace(new Component360());
   }
  }
 }
}

}
