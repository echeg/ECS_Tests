using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System39 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component317> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component75>())
   {
    q+=1;
    var com = entity.Get<Component75>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component188>())
   {
    q+=1;
    var com = entity.Get<Component188>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component326>())
   {
    q+=1;
    var com = entity.Get<Component326>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component376>())
   {
    q+=1;
    var com = entity.Get<Component376>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
