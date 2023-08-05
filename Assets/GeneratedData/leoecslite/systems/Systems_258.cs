using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System258 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component226> _p1;
EcsPool<Component356> _p2;
EcsPool<Component161> _p3;
EcsPool<Component54> _p4;
EcsPool<Component44> _pl0;
EcsPool<Component185> _pl1;
EcsPool<Component73> _pl2;
EcsPool<Component323> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component226>().Inc<Component356>().Inc<Component161>().Inc<Component54>().End();
   _p1 = _world.GetPool<Component226>();
   _p2 = _world.GetPool<Component356>();
   _p3 = _world.GetPool<Component161>();
   _p4 = _world.GetPool<Component54>();
   _pl0 = _world.GetPool<Component44>();
   _pl1 = _world.GetPool<Component185>();
   _pl2 = _world.GetPool<Component73>();
   _pl3 = _world.GetPool<Component323>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
