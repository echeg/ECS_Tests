using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System68 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component118> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component42>())
   {
    q+=1;
    var com = entity.Get<Component42>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component219>())
   {
    q+=1;
    var com = entity.Get<Component219>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component419>())
   {
    q+=1;
    var com = entity.Get<Component419>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component328>())
   {
    q+=1;
    var com = entity.Get<Component328>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
