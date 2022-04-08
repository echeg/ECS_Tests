using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System75 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component81,Component440,Component444> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component326>())
   {
    q+=1;
    var com = entity.Get<Component326>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component443>())
   {
    q+=1;
    var com = entity.Get<Component443>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component406>())
   {
    q+=1;
    var com = entity.Get<Component406>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component15>())
   {
    q+=1;
    var com = entity.Get<Component15>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
