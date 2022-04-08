using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System90 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component354> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component287>())
   {
    q+=1;
    var com = entity.Get<Component287>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component182>())
   {
    q+=1;
    var com = entity.Get<Component182>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component436>())
   {
    q+=1;
    var com = entity.Get<Component436>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component150>())
   {
    q+=1;
    var com = entity.Get<Component150>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
