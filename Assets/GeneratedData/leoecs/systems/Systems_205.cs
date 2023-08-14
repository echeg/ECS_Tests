using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System205 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component463,Component197,Component333,Component338> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component348>())
   {
    entity.Del<Component348>();
   }
   else
   {
    entity.Replace(new Component348());
   }
  }
 }
}

}
