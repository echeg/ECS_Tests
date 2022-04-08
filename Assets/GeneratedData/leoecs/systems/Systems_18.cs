using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System18 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component50> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component243>())
   {
    q+=1;
    var com = entity.Get<Component243>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component442>())
   {
    q+=1;
    var com = entity.Get<Component442>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component415>())
   {
    q+=1;
    var com = entity.Get<Component415>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component186>())
   {
    q+=1;
    var com = entity.Get<Component186>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
