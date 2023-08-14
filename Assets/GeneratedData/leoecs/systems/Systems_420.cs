using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System420 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component19,Component360,Component208,Component384> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component325>())
   {
    q+=1;
    var com = entity.Get<Component325>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
